let hash n x = (x * x) % n

// Testando a função hash
let n = 10
let x = 7
let result = hash n x
printfn "O resultado da função hash para n = %d e x = %d é: %d" n x result