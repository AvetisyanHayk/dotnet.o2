var init = function () {
    $.ajax({
        url: "/Band/JSLijst",
        dataType: "json"
    })
        .done(function (data) {
            fillData(data)
        })
        .fail(function (jqXHR, status) { alert(jqXHR + "\n" + status) });
};

var fillData = function (data) {
    var $lijst = $('#json-lijst');
    var $lijstMetLeden = $('#json-lijst-met-leden');
    if ($lijst.length[0] !== undefined) {
        fillLijst($lijst, data);
    } else if ($lijstMetLeden[0] !== undefined) {
        fillLijstMetLeden($lijstMetLeden, data);
    }

};

var fillLijst = function ($bands, bands) {
    bands.forEach(function (band) {
        var $band = $('<a>').attr("href", "/Band/Wijzig?naam=" + band.naam).text("Band: " + band.naam + ", Jaar: " + band.jaar);
        var $bandLi = $('<li>').append($band);
        $bands.append($bandLi);
    })
}

var fillLijstMetLeden = function ($ul, bands) {
    
    bands.forEach(function (band) {
        var $li = $('<li>').html("Band: " + band.naam + ", Jaar: " + band.jaar + '<br>Bandleden:');
        var $leden = $('<ul>');
        band.bandLeden.forEach(function (lid) {
            var geslacht = "Undefined";
            if (lid.geslacht === 1) {
                geslacht = "Man"
            } else if (lid.geslacht === 2) {
                geslacht = "Vrouw";
            }
            var $lid = $('<li>').text("Naam: " + lid.naam + ", Leeftijd: " + lid.leeftijd + ", Geslacht: " + geslacht + ", is alive: " + lid.isAlive);
            $leden.append($lid);
        });
        var $a = $('<a>').attr("href", "/BandLid/Maak?band=" + band.naam).text("Nieuwe lid toevoegen");
        $li.append($leden).append($a);
        $ul.append($li);
    })
}

$(document).ready(init);