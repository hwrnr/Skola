
korelacijaIzmedjuDvaVektora <- function(uslov, rezultat){
  Xprosek <- 0
  for (i in 1:length(uslov)){
    Xprosek <- Xprosek + uslov[i]
  }
  Xprosek <- Xprosek / length(uslov)
  Yprosek <- 0
  for (i in 1:length(rezultat)){
    Yprosek <- Yprosek + rezultat[i]
  }
  Yprosek <- Yprosek / length(rezultat)


  Sxy <- 0
  Sxx <- 0
  Syy <- 0

  for (i in 1:length(uslov)){
    Sxy <- Sxy + (uslov[i] - Xprosek) * (rezultat[i] - Yprosek)
    Sxx <- Sxx + (uslov[i] - Xprosek) * (uslov[i] - Xprosek)
    Syy <- Syy + (rezultat[i] - Yprosek) * (rezultat[i] - Yprosek)
  }

  r <- Sxy / sqrt(Sxx * Syy)
  r
}

srednjaVrednost <- function(vektor){
  mean(vektor)
}

maksimum <- function(vektor){
  max(vektor)
}

minimum <- function(vektor){
  min(vektor)
}

standardnaDevijacija <- function(vektor){
  sd <- 0;

  averageVektor = srednjaVrednost(vektor)

  for (i in 1:length(vektor)){
    sd <- sd + (vektor[i] - averageVektor) * (vektor[i] - averageVektor)
  }

  sd <- sd / length(vektor);
  sd <- sqrt(sd)
  sd
}

medijana <- function(vektor){
  median(vektor)
}

count <- function(vektor, uslov){
  broj <- 0
  for (i in 1:length(vektor)){
    if (vektor[i] == uslov){
      broj <- broj + 1
    }
  }
  broj
}

vratiZaBarChartGender <- function(vektor, gender){
  male <- c()
  female <- c()

  for (i in 1:length(vektor)){
    if (gender[i] == "male"){
      male <- c(male, vektor[i])
    }
    else if (gender[i] == "female"){
      female <- c(female, vektor[i])
    }
  }
  c(srednjaVrednost(male), srednjaVrednost(female))
}

vratiZaBarChartRasa <- function(vektor, race){
  a <- c()
  b <- c()
  c <- c()
  d <- c()
  e <- c()
  for (i in 1:length(vektor)){
    if (race[i] == "group A"){
      a <- c(a, vektor[i])
    }
    else if (race[i] == "group B"){
      b <- c(b, vektor[i])
    }
    else if (race[i] == "group C"){
      c <- c(c, vektor[i])
    }
    else if (race[i] == "group D"){
      d <- c(d, vektor[i])
    }
    else if (race[i] == "group E"){
      e <- c(e, vektor[i])
    }
  }
  c(srednjaVrednost(a), srednjaVrednost(b), srednjaVrednost(c), srednjaVrednost(d), srednjaVrednost(e))
}

vratiZaBarChartRucak <- function(vektor, rucak){
  free <- c()
  standard <- c()

  for (i in 1:length(vektor)){
    if (rucak[i] == "standard"){
      standard <- c(standard, vektor[i])
    }
    else if (rucak[i] == "free/reduced"){
      free <- c(free, vektor[i])
    }
  }
  c(srednjaVrednost(free), srednjaVrednost(standard))
}

vratiZaBarChartPriprema <- function(vektor, priprema){
  jeste <- c()
  nije <- c()

  for (i in 1:length(vektor)){
    if (priprema[i] == "completed"){
      jeste <- c(jeste, vektor[i])
    }
    if (priprema[i] == "none"){
      nije <- c(nije, vektor[i])
    }
  }

  c(srednjaVrednost(jeste), srednjaVrednost(nije))
}

korelacijaIzmedjuPola  <- function(vektor, gender){
  polovi <- c()
  for (i in 1:length(gender)){
    if (gender[i] == "male"){
      polovi <- c(polovi, 1)
    }
    else if (gender[i] == "female"){
      polovi <- c(polovi, 0)
    }
  }
  korelacijaIzmedjuDvaVektora(vektor, polovi)
}

korelacijaIzmedjuRucka <- function(vektor, rucak){
  polovi <- c()
  for (i in 1:length(rucak)){
    if (rucak[i] == "standard"){
      polovi <- c(polovi, 1)
    }
    else if (rucak[i] == "free/reduced"){
      polovi <- c(polovi, 0)
    }
  }
  korelacijaIzmedjuDvaVektora(vektor, polovi)
}

korelacijaIzmedjuSpremanja<- function(vektor, rucak){
  polovi <- c()
  for (i in 1:length(rucak)){
    if (rucak[i] == "completed"){
      polovi <- c(polovi, 1)
    }
    else if (rucak[i] == "none"){
      polovi <- c(polovi, 0)
    }
  }
  korelacijaIzmedjuDvaVektora(vektor, polovi)
}

korelacijaIzmedjuRasa <- function (vektor, rasa) {
  rase <- c()
  for (i in 1:length(rasa)){
    if (rasa[i] == "group A"){
      rase <- c(rase, 1)
    }
    if (rasa[i] == "group B"){
      rase <- c(rase, 2)
    }
    if (rasa[i] == "group C"){
      rase <- c(rase, 3)
    }
    if (rasa[i] == "group D"){
      rase <- c(rase, 4)
    }
    if (rasa[i] == "group E"){
      rase <- c(rase, 5)
    }
  }
  korelacijaIzmedjuDvaVektora(vektor, rase)
}

data <- read.csv(file='./StudentsPerformance.csv', header=TRUE, stringsAsFactors=FALSE)

# print(data);

gender <- unlist(data$gender)
race <- unlist(data$race)
lunch <- unlist(data$lunch)
preparation <- unlist(data$test.preparation.course)
math <- unlist(data$math.score)
reading <- unlist(data$reading.score)
writing <- unlist(data$writing.score)

pie(c(count(gender, "male"), count(gender, "female")), main="Pie of genders")

print("Srednje vrednosti na testovima: ")
print("Matematika: ")
print(srednjaVrednost(math))
print("Reading: ")
print(srednjaVrednost(reading))
print("Writing: ")
print(srednjaVrednost(writing))

print("")
print("Maksimalne vrednosti na testovima")
print("Matematika: ")
print(maksimum(math))
print("Reading: ")
print(maksimum(reading))
print("Writing: ")
print(maksimum(writing))

print("")
print("Minimalne vrednosti na testovima")
print("Matematika: ")
print(minimum(math))
print("Reading: ")
print(minimum(reading))
print("Writing: ")
print(minimum(writing))

print("")
print("Medijana vrednosti na testovima")
print("Matematika: ")
print(medijana(math))
print("Reading: ")
print(medijana(reading))
print("Writing: ")
print(medijana(writing))

print("")
print("Standardne devijacije na testovima")
print("Matematika: ")
print(standardnaDevijacija(math))
print("Reading: ")
print(standardnaDevijacija(reading))
print("Writing: ")
print(standardnaDevijacija(writing))

par(mfrow = c(3, 5))
plot(1:length(math), math, xlab="No", ylab="math", pch = 1)
abline(h = median(math), col=2)
abline(h = srednjaVrednost(math), col=3)
abline(h = minimum(math), col=1)
abline(h = maksimum(math), col=1)
barplot(vratiZaBarChartGender(math, gender), main="Ocene iz matematike", xlab="Pol", names.arg=c("male", "female"), col=c("blue", "red"))
barplot(vratiZaBarChartRasa(math, race), main="Ocene iz matematike", xlab="Rasa", names.arg=c("A", "B", "C", "D", "E"), col=c("yellow", "blue", "orange", "red", "green"))
barplot(vratiZaBarChartRucak(math, lunch), main="Ocene iz matematike", xlab="Rucak", names.arg=c("Free/reduced", "standard"), col=c("blue", "red"))
barplot(vratiZaBarChartPriprema(math, preparation), main="Ocene iz matematike", xlab="Priprema", names.arg=c("Spremao se", "Nije se spremao"), col=c("blue", "red"))

plot(1:length(reading), reading, xlab="No", ylab="reading", pch = 1)
abline(h = median(reading), col=2)
abline(h = srednjaVrednost(reading), col=3)
abline(h = minimum(reading), col=1)
abline(h = maksimum(reading), col=1)
barplot(vratiZaBarChartGender(reading, gender), main="Ocene iz citanja", xlab="Pol", names.arg=c("male", "female"), col=c("blue", "red"))
barplot(vratiZaBarChartRasa(reading, race), main="Ocene iz citanja", xlab="Rasa", names.arg=c("A", "B", "C", "D", "E"), col=c("yellow", "blue", "orange", "red", "green"))
barplot(vratiZaBarChartRucak(reading, lunch), main="Ocene iz citanja", xlab="Rucak", names.arg=c("Free/reduced", "standard"), col=c("blue", "red"))
barplot(vratiZaBarChartPriprema(reading, preparation), main="Ocene iz citanja", xlab="Priprema", names.arg=c("Spremao se", "Nije se spremao"), col=c("blue", "red"))

plot(1:length(writing), writing, xlab="No", ylab="writing", pch = 1)
abline(h = median(writing), col=2)
abline(h = srednjaVrednost(writing), col=3)
abline(h = minimum(writing), col=1)
abline(h = maksimum(writing), col=1)
barplot(vratiZaBarChartGender(writing, gender), main="Ocene iz pisanja", xlab="Pol", names.arg=c("male", "female"), col=c("blue", "red"))
barplot(vratiZaBarChartRasa(writing, race), main="Ocene iz pisanja", xlab="Rasa", names.arg=c("A", "B", "C", "D", "E"), col=c("yellow", "blue", "orange", "red", "green"))
barplot(vratiZaBarChartRucak(writing, lunch), main="Ocene iz pisanja", xlab="Rucak", names.arg=c("Free/reduced", "standard"), col=c("blue", "red"))
barplot(vratiZaBarChartPriprema(writing, preparation), main="Ocene iz pisanja", xlab="Priprema", names.arg=c("Spremao se", "Nije se spremao"), col=c("blue", "red"))

print("")
print("")
print("")
print("")
print("")
print("Razne korelacije")
print("Matematika")
print(korelacijaIzmedjuPola(math, gender))
print(korelacijaIzmedjuRasa(math, race))
print(korelacijaIzmedjuRucka(math, lunch))
print(korelacijaIzmedjuSpremanja(math, preparation))
print(korelacijaIzmedjuDvaVektora(math, math))
print(korelacijaIzmedjuDvaVektora(math, reading))
print(korelacijaIzmedjuDvaVektora(math, writing))

print("Citanje")
print(korelacijaIzmedjuPola(reading, gender))
print(korelacijaIzmedjuRasa(reading, race))
print(korelacijaIzmedjuRucka(reading, lunch))
print(korelacijaIzmedjuSpremanja(reading, preparation))
print(korelacijaIzmedjuDvaVektora(reading, math))
print(korelacijaIzmedjuDvaVektora(reading, reading))
print(korelacijaIzmedjuDvaVektora(reading, writing))

print("Pisanje")
print(korelacijaIzmedjuPola(writing, gender))
print(korelacijaIzmedjuRasa(writing, race))
print(korelacijaIzmedjuRucka(writing, lunch))
print(korelacijaIzmedjuSpremanja(writing, preparation))
print(korelacijaIzmedjuDvaVektora(writing, math))
print(korelacijaIzmedjuDvaVektora(writing, reading))
print(korelacijaIzmedjuDvaVektora(writing, writing))
