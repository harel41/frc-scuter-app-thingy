function isTeamNumGood() {
    var teamNum = document.querySelector("[id$=TxtTeamNum]");
    var error = document.querySelector("[id$=lblMessage]");
    if ((teamNum.value < 10000 && teamNum.value > 0)) {
        error.innerHTML = "";
        return true;

    }
    else {
        error.innerHTML = "מספר קבוצה לא חוקי";
        return false;
    }
}

window.onload = function () {
    this.document.forms[0].onsubmit = isTeamNumGood;

}

function isGameNumGood() {
    var gameNum = document.querySelector("[id$=TxtGameNum]");
    var error = document.querySelector("[id$=lblMessage]");
    if ( gameNum.value > 0) {
        error.innerHTML = "";
        return true;

    }
    else {
        error.innerHTML = "מספר מקצה לא חוקי";
        return false;
    }
}

window.onload = function () {
    this.document.forms[0].onsubmit = isGameNumGood;

}

function isNameGood() {
    var txtName = document.querySelector("[id$=TxtName]");
    var error = document.querySelector("[id$=lblMessage]");
    if (txtName.value.length != 0) {
        error.innerHTML = "";
        return true;

    }
    else {
        error.innerHTML = "תכניס שם";
        return false;
    }
}

window.onload = function () {
    this.document.forms[0].onsubmit = isNameGood;

}


function isPassword() {
    var pass = document.querySelector("[id$=Password]");
    var error = document.querySelector("[id$=lblMessage]");
    if (pass.value == "Admin123") {
        error.innerHTML = "";
        return true;

    }
    else {
        error.innerHTML = "סיסמא לא נכונה";
        return false;
    }
}

window.onload = function () {
    this.document.forms[0].onsubmit = isPassword;

}