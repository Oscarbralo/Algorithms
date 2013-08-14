#! /usr/bin/env python

class Stack(object):

    def __init__(self):
        self.items = []

    def _push(self, item):
        self.items.append(item)

    def _pop(self):
        return str(self.items.pop())

    def _get(self):
        return self.items

    def _empty(self):
        self.items = []

def display():

    print "1. show the stack."
    print "2. push to the stack."
    print "3. pop from the stack."
    print "4. empty the stack."
    print "5. exit."

def main():

    print "Stack Algorithm:"
    print "Do you want to deal with stack? Y/N"

    ch = raw_input()
    if (ch.lower == "n"):
        exit(0)

    elif (ch.lower() == "y"):
        LIFO = Stack()
        print "welcome to the Stack"
        print "=" * 20

        while True:
            display()
            ch = raw_input("choice: ")

            if ch == "1":
                print "your stack: " + str(LIFO._get())

            elif ch == "2":
                item = raw_input("enter your item: ")
                LIFO._push(item)

            elif ch == "3":
                print "you have poped this item: " + LIFO._pop()

            elif ch == "4":
                LIFO._empty()

            else:
                exit(0)

if __name__ == "__main__":
    main()
