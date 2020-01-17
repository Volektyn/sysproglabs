var inputs = document.getElementsByTagName('input');
var buttons = [];
var buttonCounter = 0;

for (var i = 0; i < inputs.length; i++) {
    if (inputs[i].type.toLowerCase() == 'submit') {
        console.log(inputs[i]);
        buttons[buttonCounter] = inputs[i];        
        buttonCounter++;
    }
}

for (var j = 0; j < buttons.length; j++) {
    buttons[j].onclick = function () {
        for (var p = 0; p < buttons.length; p++) {
            buttons[p].style.visibility = 'hidden';
        }
    }
}