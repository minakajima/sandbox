# coding: utf-8
import re

def main():
    f = open("analyzer\\text.txt", mode='r', encoding='utf-8')
#    f2 = open("analyzer¥¥result.ext", mode='w', encoding='utf-8')

    for line in f:
        pattern = re.compile(r'*/*/*')
        match_obj = pattern.match(line)
        if match_obj:
            print(line)

    f.close()
 #   f2.close()

if __name__ == "__main__":
    main()
