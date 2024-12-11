let weatherInfo = document.querySelector('.weather-info')
let devSection = document.querySelector('.dev-section')
let devToggle = document.querySelector('.dev-toggle')
let introSection = document.querySelector('.intro-section')
let quizSection = document.querySelector('.quiz-section')
let resultSection = document.querySelector('.result-section')
let normalModeBtn = document.querySelector('.normal-mode')
let expertModeBtn = document.querySelector('.expert-mode')
let questionContainer = document.querySelector('.question-container')
let answersContainer = document.querySelector('.answers-container')
let questionCountSpan = document.querySelector('.question-count')
let scoreInfo = document.querySelector('.score-info')
let restartBtn = document.querySelector('.restart-btn')
let finalScoreDisplay = document.querySelector('.final-score')
let playAgainBtn = document.querySelector('.play-again-btn')
let questionsTbody = document.querySelector('.questions-tbody')
let loadAllQuestionsBtn = document.querySelector('.load-all-questions-btn')

let addQuestionBtn = document.querySelector('.add-question-btn')
let modifyQuestionBtn = document.querySelector('.modify-question-btn')
let deleteQuestionBtn = document.querySelector('.delete-question-btn')
let modifyCategoryBtn = document.querySelector('.modify-category-btn')

let currentMode = ''
let currentQuestionIndex = 0
let score = 0
let totalQuestions = 10
let currentCorrectAnswer = ''
let answered = false

function loadWeather() {
    fetch('https://api.open-meteo.com/v1/forecast?latitude=47.4979&longitude=19.0402&current_weather=true')
        .then(r => r.json())
        .then(d => {
            let temp = d.current_weather.temperature
            let wind = d.current_weather.windspeed
            weatherInfo.textContent = `Budapest: ${temp}°C, Wind: ${wind} km/h`
        })
}
loadWeather()

devToggle.addEventListener('click', () => {
    devSection.classList.toggle('hidden')
})

normalModeBtn.addEventListener('click', () => {
    currentMode = 'local'
    startGame()
})
expertModeBtn.addEventListener('click', () => {
    currentMode = 'expert'
    startGame()
})

restartBtn.addEventListener('click', resetGame)
playAgainBtn.addEventListener('click', resetGame)

loadAllQuestionsBtn.addEventListener('click', () => {
    loadAllLocalQuestions()
})

function startGame() {
    introSection.classList.add('hidden')
    resultSection.classList.add('hidden')
    quizSection.classList.remove('hidden')
    currentQuestionIndex = 0
    score = 0
    answered = false
    scoreInfo.textContent = `Score: ${score}`
    questionCountSpan.textContent = `Question: ${currentQuestionIndex + 1}/${totalQuestions}`
    loadQuestion()
}

function resetGame() {
    introSection.classList.remove('hidden')
    quizSection.classList.add('hidden')
    resultSection.classList.add('hidden')
}

function loadQuestion() {
    if (currentQuestionIndex >= totalQuestions) {
        endGame()
        return
    }
    answered = false
    showLoadingIndicator()
    if (currentMode === 'local') {
        loadLocalQuestion()
    } else {
        loadExpertQuestion()
    }
}

function showLoadingIndicator() {
    answersContainer.innerHTML = ''
    questionContainer.innerHTML = `<span class="loading-indicator">Loading question...</span>`
}

function loadLocalQuestion() {
    fetch('/api/quiz')
        .then(r => r.json())
        .then(data => {
            let q = data[Math.floor(Math.random() * data.length)]
            displayQuestion(q.questionText, [q.correctAnswer, q.wrongAnswer1, q.wrongAnswer2, q.wrongAnswer3], q.correctAnswer)
        })
}

function loadExpertQuestion() {
    fetch('https://opentdb.com/api.php?amount=1&type=multiple')
        .then(r => r.json())
        .then(d => {
            if (d.results.length > 0) {
                let q = d.results[0]
                let corr = q.correct_answer
                let answers = q.incorrect_answers.concat([corr]).sort(() => Math.random() - 0.5)
                displayQuestion(q.question, answers, corr)
            }
        })
}

function displayQuestion(questionText, answers, correct) {
    questionContainer.textContent = questionText
    answersContainer.innerHTML = ''
    answers.forEach(a => {
        let btn = document.createElement('button')
        btn.innerHTML = a
        btn.addEventListener('click', () => handleAnswerClick(btn, a, correct))
        answersContainer.appendChild(btn)
    })
    currentCorrectAnswer = correct
}

function handleAnswerClick(btn, given, correct) {
    if (answered) return
    answered = true

    // Disable all buttons
    let allBtns = answersContainer.querySelectorAll('button')
    allBtns.forEach(b => b.disabled = true)

    // Check correctness
    if (given === correct) {
        score++
        scoreInfo.textContent = `Score: ${score}`
        btn.classList.add('correct')
    } else {
        btn.classList.add('wrong')
        // Highlight the correct one
        allBtns.forEach(ab => {
            if (ab.textContent === correct) {
                ab.classList.add('correct')
            }
        })
    }

    // Move to next question after a delay
    setTimeout(() => {
        currentQuestionIndex++
        questionCountSpan.textContent = `Question: ${currentQuestionIndex + 1}/${totalQuestions}`
        loadQuestion()
    }, 1000)
}

function endGame() {
    quizSection.classList.add('hidden')
    finalScoreDisplay.textContent = `You answered ${score} out of ${totalQuestions} correctly!`
    resultSection.classList.remove('hidden')
}

function loadAllLocalQuestions() {
    questionsTbody.innerHTML = ''
    fetch('/api/quiz')
        .then(r => r.json())
        .then(data => {
            data.forEach(q => {
                let tr = document.createElement('tr')
                let tdId = document.createElement('td')
                let tdQ = document.createElement('td')
                let tdC = document.createElement('td')
                let tdW1 = document.createElement('td')
                let tdW2 = document.createElement('td')
                let tdW3 = document.createElement('td')
                let tdCat = document.createElement('td')
                tdId.textContent = q.riddleId
                tdQ.textContent = q.questionText
                tdC.textContent = q.correctAnswer
                tdW1.textContent = q.wrongAnswer1
                tdW2.textContent = q.wrongAnswer2
                tdW3.textContent = q.wrongAnswer3
                tdCat.textContent = q.categoryId
                tr.appendChild(tdId)
                tr.appendChild(tdQ)
                tr.appendChild(tdC)
                tr.appendChild(tdW1)
                tr.appendChild(tdW2)
                tr.appendChild(tdW3)
                tr.appendChild(tdCat)
                questionsTbody.appendChild(tr)
            })
        })
}

addQuestionBtn.addEventListener('click', () => {
    let qtxt = document.querySelector('.new-question-text').value
    let c = document.querySelector('.new-correct-answer').value
    let w1 = document.querySelector('.new-wrong1').value
    let w2 = document.querySelector('.new-wrong2').value
    let w3 = document.querySelector('.new-wrong3').value
    let cid = parseInt(document.querySelector('.new-category-id').value)
    fetch('/api/quiz', {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({
            questionText: qtxt,
            correctAnswer: c,
            wrongAnswer1: w1,
            wrongAnswer2: w2,
            wrongAnswer3: w3,
            categoryId: cid
        })
    }).then(r => r.text())
        .then(() => {
            alert('Question added')
        })
})

modifyQuestionBtn.addEventListener('click', () => {
    let id = parseInt(document.querySelector('.mod-id').value)
    let qtxt = document.querySelector('.mod-question-text').value
    let c = document.querySelector('.mod-correct-answer').value
    let w1 = document.querySelector('.mod-wrong1').value
    let w2 = document.querySelector('.mod-wrong2').value
    let w3 = document.querySelector('.mod-wrong3').value
    fetch('/api/quiz/' + id, {
        method: 'PUT',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({
            questionText: qtxt,
            correctAnswer: c,
            wrongAnswer1: w1,
            wrongAnswer2: w2,
            wrongAnswer3: w3
        })
    }).then(r => r.text())
        .then(txt => {
            alert(txt)
        })
})

deleteQuestionBtn.addEventListener('click', () => {
    let id = parseInt(document.querySelector('.del-id').value)
    fetch('/api/quiz/' + id, {
        method: 'DELETE'
    }).then(() => {
        alert('Deleted')
    })
})

modifyCategoryBtn.addEventListener('click', () => {
    let id = parseInt(document.querySelector('.cat-id').value)
    let cname = document.querySelector('.cat-name').value
    fetch('/api/quiz/category/' + id, {
        method: 'PUT',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({
            categoryName: cname
        })
    }).then(r => r.text())
        .then(txt => alert(txt))
})
