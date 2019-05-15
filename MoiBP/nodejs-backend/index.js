const MongoClient = require('mongodb').MongoClient;
const {ObjectId} = require('mongodb')
const application = require('express')();
const bodyParser = require('body-parser');
const cors = require('cors');

application.use(cors());

var MongoUrl = "mongodb://localhost:27017";


application.use(bodyParser.json());

application.get('/film/:id', (req, res) => {
  id = req.params.id
  try{
    MongoClient.connect(MongoUrl, function(err, db) {
      if (err) throw err;
      var dbo = db.db("MIBP");
      dbo.collection("Filmovi").findOne({_id: ObjectId(id)}, function (err, result){
        if (err) throw err;
        res.setHeader('content-type', 'application/json')
        return res.status(200).send(result);
      })
      db.close();
    })
  }catch(e){
    res.status(404);
    return;
  }
});

application.get('/', (req, res) => {
    res.json({"proba": "proba"}).status(200)
});

application.get('/filmovi', (req, res) => {
  //get data from Mongo
  try{
    MongoClient.connect(MongoUrl, function(err, db) {
      if (err) throw err;
      var dbo = db.db("MIBP");
      dbo.collection("Filmovi").find({}, {"name": 1, "img" : 1}).toArray(function (err, result){
        if (err) throw err;
        // console.log(result)
        res.setHeader('content-type', 'application/json')
        return res.status(200).send(result);
      })
      db.close();
    })
  }catch(e){
    res.status(404);
    return;
  }
});

application.post('/film/comment', (req, res) => {
  var input = req.body;
  try{
    MongoClient.connect(MongoUrl, function(err, db) {
      if (err) throw err;
      var dbo = db.db("MIBP");
      dbo.collection("Filmovi").update({_id: ObjectId(input.id)}, { $push: {comments : {"autor": input.autor, "tekst": input.tekst, "id": new ObjectId() }}});
      db.close();
      res.status(201).send(input) //za slucaj da backend radi neku obradu komentara, onda bi vracao izmenjeno (na primer menja psovke sa zvezdicama)
    })
  }catch(e){
    res.status(500);
  }
});

application.delete('/film/comment', (req, res) => {
  var id = req.body.id
  var commentId = req.body.commentId
  try{
    MongoClient.connect(MongoUrl, function(err, db) {
      if (err) throw err;
      var dbo = db.db("MIBP");
      dbo.collection("Filmovi").update({_id: ObjectId(id)}, { $pull: {comments : {"id": ObjectId(commentId) }}});
      db.close();
      res.status(200).end() 
    })
  }catch(e){
    res.status(500).end();
  }
})

application.post('/film/ocena', (req, res) => {
  input = req.body
  try{
    MongoClient.connect(MongoUrl, function(err, db) {
      if (err) throw err;
      var dbo = db.db("MIBP");
      dbo.collection("Filmovi").update({"_id": ObjectId(input.id)}, { $push: { ocene: input.ocena } } )
      dbo.collection("Filmovi").findOne({"_id": ObjectId(input.id)}, {"ocene": 1, "_id": 0}, function (err, result){
        if (err) throw err;
        res.setHeader('content-type', 'application/json')
        return res.status(201).send(result);
      })
      db.close();
    })
  }catch(e){
    res.status(500);
  }
});

application.delete('/film', (req, res) => {
  var id = req.body.id
  try{
    MongoClient.connect(MongoUrl, function(err, db) {
      if (err) throw err;
      var dbo = db.db("MIBP");
      dbo.collection("Filmovi").remove({"_id": ObjectId(id)}, function (err, result){
        if (err) throw err;
        res.setHeader('content-type', 'application/json')
        return res.status(200).send(result);
      })
      db.close();
    })
  }catch(e){
    res.status(500).end();
  }
})

application.put('/film', (req, res) => {
  var id = req.body.id
  delete req.body.id
  delete req.body._id //ne sme da se menja id filma
  try{
    MongoClient.connect(MongoUrl, function(err, db) {
      if (err) throw err;
      var dbo = db.db("MIBP");
      dbo.collection("Filmovi").update({"_id": ObjectId(id)}, { $set : req.body }, function (err, result){
        if (err) throw err;
        res.setHeader('content-type', 'application/json')
        return res.status(200).send(result);
      })
      db.close();
    })
  }catch(e){
    res.status(500);
  }
})

application.post('/film', (req, res) => {
  delete req.body._id //ne sme da se stavlja id filma
  try{
    MongoClient.connect(MongoUrl, function(err, db) {
      if (err) throw err;
      var dbo = db.db("MIBP");
      dbo.collection("Filmovi").insert( req.body , function (err, result){
        if (err) throw err;
        res.setHeader('content-type', 'application/json')
        return res.status(201).send(result);
      })
      db.close();
    })
  }catch(e){
    res.status(500);
  }
})


application.listen(8000, () => {
    console.log('Up on localhost:' + 8000);
});
