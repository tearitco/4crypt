hex

: <<< ( x n -- x )
    2over 20 - rshift -rot
    lshift +
;

: not ( x -- x )
    -1 xor
;

