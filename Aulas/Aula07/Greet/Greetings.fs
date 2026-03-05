namespace Greetings

let makeHello (vip: string list) (name: string) : string =
    if List.contains name vip then
        $"Welcome, {name}!"
    else
        $"Hello, {name}."

let salute (period: DayPeriod) : string =
    match period with
    | Morning -> "Good Morning!"
    | Afternoon -> "Good Afternoon!"
    | Evening -> "Good Evening!"
