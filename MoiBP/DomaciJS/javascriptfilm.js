var filmJSON = {
  "name" : "Brzi brzic",
  "img" : "film1.jpg",
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
}

function getFilm() {
  return filmJSON;
}

function popuniFilm() {
  var film = getFilm();

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
