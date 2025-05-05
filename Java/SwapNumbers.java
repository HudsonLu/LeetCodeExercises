public class SwapNumbers {

    public static void main(String[] args) {
        // swapWithTemp();  
        swapWithoutTemp();
    }

    public static void swapWithTemp() {
        float first = 1.20f, second = 2.45f;

        System.out.println("--Before swap--");
        System.out.println("First number = " + first);
        System.out.println("Second number = " + second);

        // Swap using a temporary variable
        float temporary = first;
        first = second;
        second = temporary;

        System.out.println("--After swap--");
        System.out.println("First number = " + first);
        System.out.println("Second number = " + second);
    }


    public static void swapWithoutTemp() {
        float first = 12.0f, second = 24.5f;

        System.out.println("--Before swap--");
        System.out.println("First number = " + first);
        System.out.println("Second number = " + second);

        first = first - second; // first = 12.0 - 24.5 = -12.5
        second = first + second; // second = -12.5 + 24.5 = 12.0
        first = second - first; // first = 12.0 - (-12.5) = 24.5

        System.out.println("--After swap--");
        System.out.println("First number = " + first);
        System.out.println("Second number = " + second);
    }
}