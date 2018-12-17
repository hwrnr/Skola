var filmovi = [
  {
    "name" : "Brzi Brzic", "img" : "film1.jpg", "link" : "film1.html",
"reziser" : "Yusry Abd Halim",
  "zanr" : "Animirani",
  "trajanje" : "90min",
  "ocena" : 4.8,
  "brojOcena" : 12,
  "sinopsis" : "Brzi Brzić je mali žuti taksi koji sanja da postane glavni u svom gradu, Gasketu. Kada devojka u koju je zaljubljen biva kidnapovana, on mora da se suoči sa svojim neprijateljima u teškoj brdskoj trci. Boriće se protiv luksuznih automobila, terenaca i ogromnog kamiona sa 18 točkova, koji je vođa ove zle ekipe",
  "comments" : {
    "id" : "123",
    "autor" : "Petar Petrovic",
    "tekst" : "Veoma dobar film, sve preporuke",
    "lajkovi" : 12,
    "dislajkovi" : 1,
}




  },
  {
    "name" : "Park uzasa", "img" : "film2.jpg", "link" : "film2.html"
  },
  {
    "name" : "Zvezda je rodjena", "img" : "film3.jpg", "link" : "film3.html"
  },

  {
    "name" : "Brzi Brzic", "img" : "film1.jpg", "link" : "film1.html"
  },
  {
    "name" : "Park uzasa", "img" : "film2.jpg", "link" : "film2.html"
  },
  {
    "name" : "Zvezda je rodjena", "img" : "film3.jpg", "link" : "film3.html"
  },
  {
    "name" : "Brzi Brzic", "img" : "film1.jpg", "link" : "film1.html"
  },
  {
    "name" : "Park uzasa", "img" : "film2.jpg", "link" : "film2.html"
  },
  {
    "name" : "Zvezda je rodjena", "img" : "film3.jpg", "link" : "film3.html"
  },
  {
    "name" : "Brzi Brzic", "img" : "film1.jpg", "link" : "film1.html"
  },
  {
    "name" : "Park uzasa", "img" : "film2.jpg", "link" : "film2.html"
  },
  {
    "name" : "Zvezda je rodjena", "img" : "film3.jpg", "link" : "film3.html"
  },
]
function getData() {
  return filmovi;
}

function arrayToTable(tableData) {
    console.log(tableData);
    var table = $('<div class="fluid-container"></div>');
    var red = $('<div class="row"> </div>')
    $(tableData).each(function (i, rowData) {
        var row = $('<div class="col-md-3"></div>');
        $(rowData).each(function (j, cellData) {
            row.append($('<p>' + cellData["name"] + '</p>' + '<a href="film.html#' + i + '"><img src="' + cellData["img"] + '"/></a>'));
        });
        red.append(row);
    });
    table.append(red);
    return table;
}

function onLoadTable(){
  $('body').append(arrayToTable(getData()));
}

function getFilm(i) {
  return getData()[i];
}

function popuniFilm() {
	var type = window.location.hash.substr(1);
  var film = getFilm(type);
alert(type)

  $('#reziser').text(film["reziser"]);
  $('#zanr').text(film["zanr"]);
  $('#trajanje').text(film["trajanje"]);
  $('#slika').attr("src", film["img"]);
  $('#sinopsis').text(film["sinopsis"])
  $('#ocena').text(film["ocena"]);

  $(film["comments"]).each(function(i, data){
    $('#komentari').append('<p>' + data['autor'] + '</p>' + '<p>' + data['tekst'] + '</p></br></br>')
  });
}

function addComent() {
  $('#komentari').append('<p>' + $('#autor').val() + '</p>' + '<p>' + $('#sadrzaj').val()  + '</p></br></br>')
}

function dodajOcenu() {
  var film = getFilm();
  $('#ocena').text( ( (film['ocena'] * film["brojOcena"]) + parseInt($('#oceni').val()) ) / (film["brojOcena"] + 1)      )
}
