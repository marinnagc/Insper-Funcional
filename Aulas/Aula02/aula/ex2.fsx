let maiorDeTres a b c =
    if a >= b && a >= c then a
    elif b >= a && b >= c then b
    else c

// Testes
printfn $"{maiorDeTres 1 2 3}"
printfn $"{maiorDeTres 3 1 2}"
printfn $"{maiorDeTres 1 1 2}"
printfn $"{maiorDeTres 5 5 1}"
printfn $"{maiorDeTres 1 2 2}"
printfn $"{maiorDeTres 2 2 2}"
