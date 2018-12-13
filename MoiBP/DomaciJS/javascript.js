var filmovi = [
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
            row.append($('<p>' + cellData["name"] + '</p>' + '<a href="' + cellData["link"] + '"><img src="' + cellData["img"] + '"/></a>'));
        });
        red.append(row);
    });
    table.append(red);
    return table;
}

function onLoadTable(){
  $('body').append(arrayToTable(getData()));
}

 // $(document).ready(onLoadTable());
