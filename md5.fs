\ MD5 message digest algorithm
\ See RFC 1321 for details
\ (c) 2012 Weldon Goree

\ Circular shift

hex

: <<< ( x n -- x )
    2over 20 - rshift -rot
    lshift +
;