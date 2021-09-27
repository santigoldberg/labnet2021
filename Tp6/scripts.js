function limpiar() {
    const todosLosCampos = document.querySelectorAll("input");
    for (let campo of todosLosCampos) {
        if (campo.type === "text") {
            campo.value = "";
        }
        else if (campo.type === "radio") {
            campo.checked = false;
        }
    }
}

function chequear(event) {
    event.preventDefault();
    const nombre = document.getElementById("name");
    const apellido = document.getElementById("lastName");
    let errores = [];
    if (nombre.value.trim() === "") {
        errores.push("Nombre")
    }
    if (apellido.value.trim() === "") {
        errores.push("Apellido")
    }
    if (errores.length === 1) {
        alert("Complete su " + errores[0]);
    }
    else if (errores.length > 1) {
        const ultimoError = errores.pop();
        alert("Complete su " + errores.join(", ") + " y " + ultimoError);
    }
    else {
        event.target.submit();
    }
}