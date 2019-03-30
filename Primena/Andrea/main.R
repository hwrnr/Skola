
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

data <- read.csv(file='./data.csv', header=TRUE)

# print(data);

fixedAudacity <- as.numeric(unlist(data$fixed.acidity), na.rm=TRUE)
acid <- as.numeric(unlist(data$acid), na.rm=TRUE)
chlorides <- as.numeric(unlist(data$chlorides), na.rm=TRUE)
alcohol <- as.numeric(unlist(data$alcohol), na.rm=TRUE)
quality <- as.numeric(unlist(data$quality), na.rm=TRUE)

# print("Srednje vrednosti na testovima: ")
# print("Fixed audacity: ")
# print(srednjaVrednost(fixedAudacity))
# print("Subscribers: ")
# print(srednjaVrednost(subscribers))
# print("views: ")
# print(srednjaVrednost(views))
#
# print("")
# print("Maksimalne vrednosti")
# print("Uploads: ")
# print(maksimum(uploads))
# print("Subscribers: ")
# print(maksimum(subscribers))
# print("Views: ")
# print(maksimum(views))
#
# print("")
# print("Minimalne vrednosti")
# print("Uploads: ")
# print(minimum(uploads))
# print("Subscribers: ")
# print(minimum(subscribers))
# print("Views: ")
# print(minimum(views))
#
# print("")
# print("Medijana vrednosti")
# print("Uploads: ")
# print(medijana(uploads))
# print("Subscribers: ")
# print(medijana(subscribers))
# print("Views: ")
# print(medijana(views))
#
# print("")
# print("Standardne devijacije")
# print("Uploads: ")
# print(standardnaDevijacija(uploads))
# print("Subscribers: ")
# print(standardnaDevijacija(subscribers))
# print("Views: ")
# print(standardnaDevijacija(views))

# par(mfrow = c(3, 5))
# plot(1:length(math), math, xlab="No", ylab="math", pch = 1)
# abline(h = median(math), col=2)
# abline(h = srednjaVrednost(math), col=3)
# abline(h = minimum(math), col=1)
# abline(h = maksimum(math), col=1)
# barplot(vratiZaBarChartGender(math, gender), main="Ocene iz matematike", xlab="Pol", names.arg=c("male", "female"), col=c("blue", "red"))
# barplot(vratiZaBarChartRasa(math, race), main="Ocene iz matematike", xlab="Rasa", names.arg=c("A", "B", "C", "D", "E"), col=c("yellow", "blue", "orange", "red", "green"))
# barplot(vratiZaBarChartRucak(math, lunch), main="Ocene iz matematike", xlab="Rucak", names.arg=c("Free/reduced", "standard"), col=c("blue", "red"))
# barplot(vratiZaBarChartPriprema(math, preparation), main="Ocene iz matematike", xlab="Priprema", names.arg=c("Spremao se", "Nije se spremao"), col=c("blue", "red"))
#
# plot(1:length(reading), reading, xlab="No", ylab="reading", pch = 1)
# abline(h = median(reading), col=2)
# abline(h = srednjaVrednost(reading), col=3)
# abline(h = minimum(reading), col=1)
# abline(h = maksimum(reading), col=1)
# barplot(vratiZaBarChartGender(reading, gender), main="Ocene iz citanja", xlab="Pol", names.arg=c("male", "female"), col=c("blue", "red"))
# barplot(vratiZaBarChartRasa(reading, race), main="Ocene iz citanja", xlab="Rasa", names.arg=c("A", "B", "C", "D", "E"), col=c("yellow", "blue", "orange", "red", "green"))
# barplot(vratiZaBarChartRucak(reading, lunch), main="Ocene iz citanja", xlab="Rucak", names.arg=c("Free/reduced", "standard"), col=c("blue", "red"))
# barplot(vratiZaBarChartPriprema(reading, preparation), main="Ocene iz citanja", xlab="Priprema", names.arg=c("Spremao se", "Nije se spremao"), col=c("blue", "red"))
#
# plot(1:length(writing), writing, xlab="No", ylab="writing", pch = 1)
# abline(h = median(writing), col=2)
# abline(h = srednjaVrednost(writing), col=3)
# abline(h = minimum(writing), col=1)
# abline(h = maksimum(writing), col=1)
# barplot(vratiZaBarChartGender(writing, gender), main="Ocene iz pisanja", xlab="Pol", names.arg=c("male", "female"), col=c("blue", "red"))
# barplot(vratiZaBarChartRasa(writing, race), main="Ocene iz pisanja", xlab="Rasa", names.arg=c("A", "B", "C", "D", "E"), col=c("yellow", "blue", "orange", "red", "green"))
# barplot(vratiZaBarChartRucak(writing, lunch), main="Ocene iz pisanja", xlab="Rucak", names.arg=c("Free/reduced", "standard"), col=c("blue", "red"))
# barplot(vratiZaBarChartPriprema(writing, preparation), main="Ocene iz pisanja", xlab="Priprema", names.arg=c("Spremao se", "Nije se spremao"), col=c("blue", "red"))

par(mfrow = c(3, 5))

plot(1:length(fixedAudacity), fixedAudacity, xlab="No", ylab="Fixed Audacity", pch = 1)

plot(1:length(acid), acid, xlab="No", ylab="Acid", pch = 1)
abline(h = median(acid), col=2)
abline(h = srednjaVrednost(acid), col=3)
abline(h = minimum(acid), col=1)
abline(h = maksimum(acid), col=1)

plot(acid, fixedAudacity, xlab="Acid", ylab="Fixed Audacity", pch = 1)
plot(acid, alcohol, xlab="Acid", ylab="alcohol", pch = 1)
plot(fixedAudacity, alcohol, xlab="Fixed Audacity", ylab="alcohol", pch = 1)
plot(fixedAudacity,chlorides, xlab="Fixed Audacity", ylab="chlorides", pch = 1)

# print("")
# print("")
# print("")
# print("")
# print("")
# print("Razne korelacije")
# print("Rank")
print(korelacijaIzmedjuDvaVektora(acid, fixedAudacity))
print(korelacijaIzmedjuDvaVektora(acid, alcohol))
print(korelacijaIzmedjuDvaVektora(fixedAudacity, alcohol))
print(korelacijaIzmedjuDvaVektora(fixedAudacity, chlorides))
# print(korelacijaIzmedjuDvaVektora(rank, subscribers))
# print(korelacijaIzmedjuDvaVektora(rank, views))
# print("Uploads")
# print(korelacijaIzmedjuDvaVektora(uploads, subscribers))
# print(korelacijaIzmedjuDvaVektora(uploads, views))
# print("Subscribers")
# print(korelacijaIzmedjuDvaVektora(subscribers, views))
#
