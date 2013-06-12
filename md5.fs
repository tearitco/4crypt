\ MD5 message digest algorithm
\ See RFC 1321 for details
\ (c) 2012-2013 Weldon Goree

\ Circular shift

s" lib.fs" included

: find-pad-length ( n -- n )
    dup 200 mod 1C0 -
    dup 0 <= if
	dup 200 +
    then
;

\ NB: pad-message incorrectly assumes the message is byte-aligned at its end. This is a bug.

: pad-message ( x-addr n -- x-addr n )
    find-pad-length over +
        
;

: md5 ( x-addr n -- x-addr n )
  pad-message
;