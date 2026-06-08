public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new();

        foreach (string token in tokens) {
            if (
                token == "+" ||
                token == "-" ||
                token == "/" ||
                token == "*"
            ) {
                int b = stack.Pop();
                int a = stack.Pop();

                int calculation = token switch {
                    "+" => a + b,
                    "-" => a - b,
                    "/" => a / b,
                    "*" => a * b,
                };

                stack.Push(calculation);
            } else {
                stack.Push(int.Parse(token));
            }
        }

        return stack.Pop();
    }
}
