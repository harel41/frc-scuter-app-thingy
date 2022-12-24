function isTeamNumGood() {
    var teamNum = document.querySelector("[id$=TxtTeamNum]");
    var error = document.querySelector("[id$=lblMessage]");
    if ((teamNum.value < 1000 && teamNum.value > 0)) {
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