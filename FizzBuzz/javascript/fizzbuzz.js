// appraoch 1
for (counter = 0; counter < 100; counter++) {

    if (counter % 3 === 0 && counter % 5 === 0) {
    console.log('FizzBuzz');
    } else if (counter % 5 === 0) {
    console.log('Buzz');
    } else if (counter % 3 === 0) {
    console.log('Fizz');
    } else {console.log(counter);
    }
    
}


// approach 2
for (var i = 1; i < 101; i++) {
    if (i % 15 == 0) console.log("FizzBuzz");
    else if (i % 3 == 0) console.log("Fizz");
    else if (i % 5 == 0) console.log("Buzz");
    else console.log(i);
}