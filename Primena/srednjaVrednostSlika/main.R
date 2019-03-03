visina <- c(192, 174, 194, 185, 196, 161, 181, 192, 186, 170)

print(visina)

averageVisina <- 0;

for (i in 1:length(visina)){
  averageVisina <- averageVisina + visina[i];
}

averageVisina <- averageVisina / length(visina)

print(averageVisina)

plot(1:length(visina), visina,ylab="visina",xlab="Broj kandidata u MUPU",pch=3)
abline(h = averageVisina, col=2)

standardnaDevijacija <- 0;

for (i in 1:length(visina)){
  standardnaDevijacija <- standardnaDevijacija + (visina[i] - averageVisina) * (visina[i] - averageVisina)
}

standardnaDevijacija <- standardnaDevijacija / length(visina);
standardnaDevijacija <- sqrt(standardnaDevijacija)

print(standardnaDevijacija)

