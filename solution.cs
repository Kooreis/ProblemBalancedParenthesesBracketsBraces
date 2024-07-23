Here is a JavaScript console application that solves the problem:

```javascript
function isBalanced(str) {
    let stack = [];
    let map = {
        '(': ')',
        '[': ']',
        '{': '}'
    }

    for (let i = 0; i < str.length; i++) {
        if (str[i] === '(' || str[i] === '{' || str[i] === '[' ) {
            stack.push(str[i]);
        }
        else {
            let last = stack.pop();

            if (str[i] !== map[last]) {
                return false;
            }
        }
    }
    
    if (stack.length !== 0) {
        return false;
    }

    return true;
}

console.log(isBalanced("(){}[]")); // true
console.log(isBalanced("({[}])")); // false
console.log(isBalanced("({[]})")); // true
console.log(isBalanced("({[})")); // false
console.log(isBalanced("({[]})[")); // false
```

This console application defines a function `isBalanced` that checks if a string of parentheses, brackets, and braces is balanced. It uses a stack to keep track of the opening brackets and a map to match the opening and closing brackets. It iterates over the string, pushing any opening brackets onto the stack, and popping the last opening bracket from the stack if it encounters a closing bracket. If the closing bracket doesn't match the last opening bracket, it returns false. If there are any opening brackets left in the stack after iterating over the string, it also returns false. If none of these conditions are met, it returns true. The console.log statements at the end test the function with various inputs.