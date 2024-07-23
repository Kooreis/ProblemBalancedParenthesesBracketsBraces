Here is a TypeScript console application that solves the problem:

```typescript
class Stack<T> {
    private items: T[] = [];

    push(element: T) {
        this.items.push(element);
    }

    pop(): T | undefined {
        return this.items.pop();
    }

    peek(): T | undefined {
        return this.items[this.items.length - 1];
    }

    isEmpty(): boolean {
        return this.items.length === 0;
    }
}

function isBalanced(s: string): boolean {
    const stack = new Stack<string>();
    const open = ['(', '[', '{'];
    const close = [')', ']', '}'];

    for (let i = 0; i < s.length; i++) {
        if (open.includes(s[i])) {
            stack.push(s[i]);
        } else if (close.includes(s[i])) {
            const last = stack.pop();
            if (open.indexOf(last as string) !== close.indexOf(s[i])) {
                return false;
            }
        }
    }

    return stack.isEmpty();
}

console.log(isBalanced('()[]{}')); // true
console.log(isBalanced('([{}])')); // true
console.log(isBalanced('([)]')); // false
console.log(isBalanced('[')); // false
```

This application uses a stack to keep track of the opening parentheses, brackets, and braces. When it encounters a closing symbol, it pops the last opening symbol from the stack and checks if they match. If they don't match or if there are any opening symbols left in the stack at the end, the string is not balanced.