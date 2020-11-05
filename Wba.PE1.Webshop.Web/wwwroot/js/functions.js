"use strict";

var imgMotor, radColors;
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
    radColors = document.querySelectorAll('label');
}

function AddEvents() {
    if (radColors.length > 1) {
        for (let i = 0; i < radColors.length; i++) {
            const element = radColors[i];
            element.addEventListener('click', ChangeColor);
            //console.log(element);
        }
    }
    
}

function ChangeColor() {
    let brand, motor, color;
    brand = inputBrand.value.toLowerCase();
    motor = inputName.value.toLowerCase();
    color = this.id.toLowerCase();

    let path = `/images/${brand}/${motor}/${color}.jpg`;

    imgMotor.setAttribute('src', path);

        
    
}