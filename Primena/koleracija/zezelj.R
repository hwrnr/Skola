visina <- c(188, 175, 194, 174, 192, 186, 198, 193)
tezina <- c(87, 64, 77, 96, 80, 75, 100, 82)
velicinaCipela <- c(48, 43, 47, 43, 45, 43, 49, 47)
prosek <- c(4.45, 4.77, 4.54, 5.00, 5.00, 4.92, 3.92, 4.77)

par(mfrow = c(2, 2))
plot(visina, tezina, xlab="Visina", ylab="Tezina", pch = 1)
plot(visina, velicinaCipela, xlab="Visina", ylab="Velicina cipela", pch = 2)
plot(visina, prosek, xlab="Visina", ylab="Prosek", pch = 3)
