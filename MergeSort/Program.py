#! /usr/bin/env python

from sys import argv

def mergesort(left, right):
    result = []
    i, j = 0, 0

    while i < len(left) and j < len(right):
        if left[i] <= right[j]:
            result.append(left[i])
            i += 1

        else:
            result.append(right[j])
            j += 1

    result += left[i:]
    result += right[j:]

    return result

def merge(lst):
    if len(lst) <= 1:
        return lst

    middle = len(lst) / 2
    left = merge(lst[ : middle])
    right = merge(lst[middle : ])

    return mergesort(left, right)

def main():
    if len(argv) < 2:
        print "Usage: {0} <numbers>.".format(argv[0])
        exit(1)

    ur_pkg = map(int, argv[1:])
    print "[+] Your package before sorting >> " + str(ur_pkg)

    nw_pkg = merge(ur_pkg)
    print "[+] Your package after merge sorting >> " + str(nw_pkg)

if __name__ == '__main__':
    main()
