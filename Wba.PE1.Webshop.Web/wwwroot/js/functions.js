"use strict";

var imgMotor, lblColors, btnColors, colorId;
var inputName, inputBrand

window.addEventListener('load',Initialize);

function Initialize() {
    BindElements();
    AddEvents();
}

function BindElements() {
    inputBrand = document.querySelector("#inputBrand");
    inputName = document.querySelector("#inputName");
    imgMotor = document.querySelector("#imgMotor");
    lblColors = document.querySelectorAll('label');
    btnColors = document.querySelectorAll('input[name="colors"]');
}

function AddEvents() {
    if (lblColors.length > 1) {
        for (let i = 0; i < lblColors.length; i++) {
            const lbl = lblColors[i];
            lbl.addEventListener('click', ChangeColor);
        }
    }
}

function ChangeColor() {
    let brand, motor, color;

    for (var j = 0; j < lblColors.length; j++) {
        const label = lblColors[j];
        label.setAttribute('class', 'btn btn-info btn-lg');
    }

    brand = inputBrand.value.toLowerCase();
    motor = inputName.value.toLowerCase();
    color = this.id.toLowerCase();

    let path = `/images/${brand}/${motor}/${color}.jpg`;

    imgMotor.setAttribute('src', path);

    this.setAttribute('class', 'btn btn-primary btn-lg active');
    colorId = this.id;
    ChangeChecked();
}

function ChangeChecked() {
    for (var i = 0; i < btnColors.length; i++) {
        const button = btnColors[i];
        if (colorId == button.value) {
            button.checked = true;
        }
    }
}