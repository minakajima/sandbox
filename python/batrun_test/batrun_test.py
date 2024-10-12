import sys

def main():
    if len(sys.argv) != 2:
        print("Usage: batrun_test.py <input>")
        return 1

    input_value = sys.argv[1]
    # ここで何らかの処理を行う
    result = f"Received input: {input_value}"
    
    print(result)

    if(input_value == "1"):
        return 1
    return 0

if __name__ == "__main__":
    print("Hello, batrun_test.py")
    exit_code = main()
    sys.exit(exit_code)