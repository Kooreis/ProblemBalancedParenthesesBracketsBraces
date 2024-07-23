```cpp
#include <iostream>
#include <stack>
#include <string>

bool arePair(char opening, char closing) {
    if(opening == '(' && closing == ')') return true;
    else if(opening == '{' && closing == '}') return true;
    else if(opening == '[' && closing == ']') return true;
    return false;
}

bool areParenthesesBalanced(std::string exp) {
    std::stack<char> S;
    for(int i =0; i<exp.length(); i++) {
        if(exp[i] == '(' || exp[i] == '{' || exp[i] == '[')
            S.push(exp[i]);
        else if(exp[i] == ')' || exp[i] == '}' || exp[i] == ']') {
            if(S.empty() || !arePair(S.top(), exp[i]))
                return false;
            else
                S.pop();
        }
    }
    return S.empty() ? true:false;
}

int main() {
    std::string expression;
    std::cout<<"Enter an expression:  ";
    std::cin>>expression;
    if(areParenthesesBalanced(expression))
        std::cout<<"Balanced\n";
    else
        std::cout<<"Not Balanced\n";
}
```