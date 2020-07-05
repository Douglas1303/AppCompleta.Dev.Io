var validarExclusao = function (id, evento) {
    if (confirm("Confirma a exclusão!")) {
        return true;
    }
    else {
        evento.preventDefault();
        return false; 
    }
}