// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Speech Recogniztion Part
let recognition; // Declare recognition variable globally
function toggleSpeechRecognition() {
    if (recognition && recognition.running) {
        recognition.stop(); // Stop speech recognition if it's running
    } else {
        startSpeechRecognition(); // Start speech recognition if it's not running
    }

    var lottieContainer = document.getElementById("lottie-container");
    var lottiePlayer = document.getElementById("lottie-player");

    if (lottieContainer.style.display === "none") {
        lottieContainer.style.display = "block";
        lottiePlayer.play();
        document.getElementById("voice-button-speech").style.display = "none";
        document.getElementById("display-active-speech").style.fontSize = "48px";
    }
}

function startSpeechRecognition() {
    recognition = new webkitSpeechRecognition(); // Create a new SpeechRecognition object

    recognition.onresult = function (event) {
        const transcript = event.results[0][0].transcript; // Get the recognized transcript
        updateDisplay(transcript); // Update the display with the recognized text
    };

    recognition.onend = function () {
        toggleSpeechRecognition(); // Automatically stop and toggle speech recognition when you stop speaking
    };

    recognition.start(); // Start speech recognition
}

function updateDisplay(text) {
    const displayDiv = document.querySelector('.Display-Active');
    displayDiv.textContent = text; // Update the text content of the display div
    speechInputButtonClick(text);
}

// Send Post Method
function sendButtonClick(buttonName) {
    $.ajax({
        url: '/Home/ButtonClick',
        type: 'POST',
        data: { buttonName: buttonName },
        success: function (response) {
            console.log('Button click sent successfully.');
        },
        error: function (error) {
            console.error('Error sending button click:', error);
        }
    });
}

function speechInputButtonClick(speech) {
    $.ajax({
        url: '/Home/SpeechTextInput',
        type: 'POST',
        data: { speech: speech },
        success: function (response) {
            console.log('Button click sent successfully.');
        },
        error: function (error) {
            console.error('Error sending button click:', error);
        }
    });
}

$(document).ready(function () {
    $('#sendButton').click(function () {
        var inputText = $('input[type="text"]').val().trim();
        sendButtonClick(inputText);
    });
});
