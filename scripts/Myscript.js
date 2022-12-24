function isTeamNumGood() {
    var teamNum = document.querySelector("[id$=TxtTeamNum]");
    var error = document.querySelector("[id$=lblMessage]");
    if (teamNum.value < 9999 && teamNum.value > 1) {
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