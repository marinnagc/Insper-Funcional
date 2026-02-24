(* Snippets da aula 04 *)
// let rec fat n =
//     if n <= 1
//     then 1
//     else n * fat (n - 1)

// let rec fat n =
//     match n with
//     | 0 -> 1
//     | 1 -> 1
//     | n -> n * fat (n - 1)

// let rec fat n =
//     match n with
//     | n when n <= 1 -> 1
//     | n -> n * fat (n - 1)

// let rec fat n =
//     match n with
//     | n when n < 0 -> failwith "n must be positive"
//     | n when n <= 1 -> 1
//     | n -> n * fat (n - 1)

// let int_to_bool i =
//     match i with
//     | 0 -> false
//     | _ -> true (* Caso contrário *)

// type day = Sun | Mon | Tue | Wed | Thu | Fri | Sat

// let int_to_day (i: int) : day =
//     match i % 7 with
//     | 0 -> Sun
//     | 1 -> Mon
//     | 2 -> Tue
//     | 3 -> Wed
//     | 4 -> Thu
//     | 5 -> Fri
//     | 6 -> Sat
//     | _ -> failwith "This should never happen"

// printfn "%A" (int_to_day 0)

// let rec sum_list lst =
//     match lst with
//     | [] -> 0 (* Lista vazia *)
//     | h :: t -> h + sum_list t (* Desempacota head do tail *)

// let my_list = [ 1; 2; 3; 4; 5 ]

// printfn "Sum: %d\n" (sum_list my_list)

// let my_list = [1; 2; 3]
// printfn "%A" (my_list @ [4])
// printfn "%A" my_list (* Qual a saída? *)

// let my_list = [1; 2; 3]
// let x = my_list[2]

// let my_list = [1; 2; 3]
// let x = List.item 2 my_list


// let person = ("Alice", 30)
// let (name, age) = person  (* unpack *)
// printfn "%s is %d years old\n" name age

// type Person = { name: string; age: int; country: string }

// let alice: Person = { name = "Alice"; age = 9; country = "Japan" }
// let raul: Person = { age = 40; name = "Raul"; country = "Brazil" }

// printfn "%s is %d years old from %s\n" alice.name alice.age alice.country

// let describe_person person =
//     match person with
//         | { name = "Raul"; country = "Brazil" } -> "Raul from Brazil"
//         | { country = "Brazil" } -> "Someone from Brazil"
//         | _ -> "Someone from Earth"