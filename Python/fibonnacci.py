# Fibonnacci

def fibonacci_iterative(n):
    i = 0
    j = 1

    print(i) # 0 
    print(j) # 1


    numberOfLoops = 0
    while (numberOfLoops<n): # 10 iterations
        f=i+j
        print(f) # 1 
        i = j # 1
        j = f # 1
        numberOfLoops += 1
        

def main():
    fibonacci_iterative(10)


if __name__ == "__main__":
    main()

# 0 1 1 2 3 5 8 13 21 34 ...

