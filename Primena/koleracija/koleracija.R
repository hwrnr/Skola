nekaRandomF <- function(uslov, rezultat){
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
  print(r)
}

#Zubic
uslov <- c(192, 174, 194, 185, 196, 161, 181, 202, 186, 170, 192, 185,179, 187,167,200,197)
rezultat <- c(100, 70, 92, 88, 96, 59, 80, 90, 121, 59, 87, 82, 75,85, 67, 100,95)

#Zezelj
visina <- c(188, 175, 194, 174, 192, 186, 198, 193)
tezina <- c(87, 64, 77, 96, 80, 75, 100, 82)
velicinaCipela <- c(48, 43, 47, 43, 45, 43, 49, 47)
prosek <- c(4.45, 4.77, 4.54, 5.00, 5.00, 4.92, 3.92, 4.77)

nekaRandomF(visina, tezina)
nekaRandomF(visina, velicinaCipela)
nekaRandomF(visina, prosek)

par(mfrow=c(2,2))
plot(visina, prosek,ylab="prosek",xlab="visina",pch=3)
plot(visina, tezina,ylab="prosek",xlab="visina",pch=3)
plot(visina, velicinaCipela,ylab="prosek",xlab="visina",pch=3)
plot(prosek, tezina,ylab="prosek",xlab="visina",pch=3)
