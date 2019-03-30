
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

korelacijaIzmedjuPola  <- function(vektor, gender){
  polovi <- c()
  for (i in 1:length(gender)){
    if (gender[i] == "Male"){
      polovi <- c(polovi, 1)
    }
    else if (gender[i] == "Female"){
      polovi <- c(polovi, 0)
    }
  }
  korelacijaIzmedjuDvaVektora(vektor, polovi)
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
    if (gender[i] == "Male"){
      male <- c(male, vektor[i])
    }
    else if (gender[i] == "Female"){
      female <- c(female, vektor[i])
    }
  }
  print(srednjaVrednost(na.omit(male)))
  print(srednjaVrednost(na.omit(female)))
  c(srednjaVrednost(na.omit(male)), srednjaVrednost(na.omit(female)))
}

data <- read.csv(file='./data.csv', header=TRUE)

# print(data);

number <- as.numeric(unlist(data$Number), na.rm=TRUE)
city <- (unlist(data$City))
gender <- (unlist(data$Gender))
age <- as.numeric(unlist(data$Age), na.rm=TRUE)
income <- as.numeric(unlist(data$Income), na.rm=TRUE)
illness <- (unlist(data$Illness))

print("Srednje vrednosti: ")
print("Age: ")
print(srednjaVrednost(age))
print("Income: ")
print(srednjaVrednost(income))


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

par(mfrow = c(3, 5)) #postavlja grafike u 3x5
barplot(vratiZaBarChartGender(age, gender), main="Naslova grafika", xlab="Pol", names.arg=c("male", "female"), col=c("blue", "red"))
barplot(c(count(gender, "Male"), count(gender, "Female")))
plot(age, income)
plot(1:length(age), age, xlab="No", ylab="reading", pch = 1)
abline(h = median(age), col=2)
abline(h = srednjaVrednost(age), col=3)
abline(h = minimum(age), col=1)
abline(h = maksimum(age), col=1)

print("")
print("")
print("")
print("")
print("")
print("Razne korelacije")
print("Age i income")
print(korelacijaIzmedjuDvaVektora(age, income))
print(korelacijaIzmedjuPola(age, gender))
