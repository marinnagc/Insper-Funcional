let rec somaDigitos n =
    if n < 0 then
        somaDigitos -n
    elif n < 10 then
        n
    else 
        let digitoDasUnidades = n % 10
        let outrosDigitos = n / 10
        digitoDasUnidades + somaDigitos outrosDigitos

// Testes
printfn $"{somaDigitos 0}"
printfn $"{somaDigitos 9}"
printfn $"{somaDigitos 10}"
printfn $"{somaDigitos 1234}"
printfn $"{somaDigitos -4321}"
