fn main() {
    println!("Is 19 a happy number? {:?}", is_happy(&19)); // Expected output: true
    println!("Is 5 a happy number? {:?}", is_happy(&5)); //Expected output: false
}

fn thing(number: &u32) -> u32 {
    let mut n: u32 = 0;
    for i in 0..number.to_string().chars().count() {
        n = &n + number
            .to_string()
            .chars()
            .map(|s| s.to_string().parse().expect("parser error"))
            .collect::<Vec<u32>>()[i].pow(2);
    }
    n
}

pub fn is_happy(number: &u32) -> bool {
    let mut results:Vec<u32> = [].to_vec();
    let mut result:u32 = thing(&number);
    results.push(result);

    while results.iter().filter(|&n| *n == result).count() < 2 {
        result = thing(&result);
        results.push(result);
    }
    result == 1
}

//tests
#[cfg(test)]
mod tests{
    use crate::is_happy;

    #[test]
    fn happy() {
        let num:u32 = 19;
        assert_eq!(true, is_happy(&num));
    }
    #[test]
    fn unhappy() {
        let num:u32 = 5;
        assert_eq!(false, is_happy(&num))
    }

}