#! /usr/bin/env python

from sys import argv

def SmallestIndx(pkg, ele):
    min_Indx = ele
    for j in range(ele + 1, len(pkg)):
        if pkg[j] < pkg[min_Indx]:
            min_Indx = j

    return min_Indx

def SelecSort(pkg):
    for i in range(len(pkg)):
        smallest_index = SmallestIndx(pkg, i)
        pkg[smallest_index], pkg[i] = pkg[i], pkg[smallest_index]

    return pkg

def main():
    if (len(argv) < 2):
        print "Usage: {0} <numbers>".format(argv[0])
        exit(1)

    pkg = map(int, argv[1:])
    print '[*] Your package before sorting >> ' + str(pkg)

    newpkg = SelecSort(pkg)
    print '[+] Your package after sorting >> ' + str(newpkg)

if __name__ == "__main__":
    main()
