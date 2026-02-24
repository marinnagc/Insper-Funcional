let rec tribonacciIngenuo n =
    if n <= 0 then
        0
    elif n = 1 then
        1
    elif n = 2 then
        1
    else
        tribonacciIngenuo (n - 1) + tribonacciIngenuo (n - 2) + tribonacciIngenuo (n - 3)


let rec proximoValor n n_atual ultimo penultimo antepenultimo =
    if n = n_atual then 
        ultimo + penultimo + antepenultimo
    else 
        proximoValor n (n_atual + 1) (ultimo + penultimo + antepenultimo) ultimo penultimo


let tribonacciEficiente n =
    if n <= 0 then 
        0
    elif n <= 2 then
        1
    else
        let n_atual = 3
        let ultimo = 1
        let penultimo = 1
        let antepenultimo = 0
        proximoValor n n_atual ultimo penultimo antepenultimo

printfn $"{tribonacciIngenuo 6}"
printfn $"{tribonacciEficiente 6}"