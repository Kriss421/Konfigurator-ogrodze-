document.getElementById('submit-quote-button').addEventListener('click', function () {
    var imie = document.getElementById('imie').value;
    var nazwisko = document.getElementById('nazwisko').value;
    var telefon = document.getElementById('telefon').value;
    var montaz = document.getElementById('montaz').value;
    var kodPocztowy = document.getElementById('kod_pocztowy').value;
    var plik = document.getElementById('plik').value;

    if (imie === '' || nazwisko === '' || telefon === '' || montaz === '' || kodPocztowy === '' || plik === '') {
        alert('Proszę wypełnić wszystkie pola formularza.');
    } else {
        // Tutaj możesz dodać kod do wysłania formularza lub inne działania
        alert('Formularz został wysłany!');
    }
});