function thing(num:number): number {
    let n:number = 0
    for (let i = 0; i < num.toString().length; i++){
        n += num.toString().split('').map((num) => {return Number(num)})[i]**2
    }
    return n
}

function count(arr, o):number {
    let c:number = 0
    arr.forEach((v) => ( v == o && c++))
    return c
}

export function is_happy(number:number):boolean {
    let results:Array<number> = []
    let result:number = thing(number)
    results.push(result)

    while (count(results, result) < 2){
        result = thing(result)
        results.push(result)
    }
    return (result == 1)
}