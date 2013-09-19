#! /usr/bin/env python

from sys import argv

def LinearSearch(pkg, ele):
    for i in range(len(pkg)):
        if pkg[i] == ele:
            return True

    return False

def main():
    if ((len(argv)) < 2):
        print "Usage: {0} <package> <wanted>".format(argv[0])
        exit(1)

    pkg = argv[1:len(argv) - 1]
    wanted = argv[-1]

    if LinearSearch(pkg, wanted):
        print '[+] found your element in your package.'
        print '[+] {0} is number {1} from package.'.format(wanted, pkg.index(wanted) + 1)
        exit(0)

    else:
        print '[!!] sorry {0} not found in your package.'.format(wanted)
        exit(0)

if __name__ == "__main__":
    main()

