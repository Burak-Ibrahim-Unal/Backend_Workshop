## About Codes
This is OOP and algorithm solution that made for Cs-Tech company

#  Calculation of the current state of the two sides (black and white) according to the pieces on the chessboard.

**1.** Checking whether a piece is under threat occurs when there is one or more pieces of the opposite color that threaten that piece.<br />
**2.** Table 1 Chess Pieces In Table 1, the points of the pieces are given. If a piece is not threatened, it gets the score on the table.<br />
**3.** If a piece is threatened by any of the opponent's pieces, the threatened piece's score is half its score in Table 1.<br />
**4.** Pieces that only the knight and the bishop can destroy will be half scored

## About Chess Pieces
* Pawn= p = 1 point
* Knight= a = 3 points
* Bishop= f = 3 points
* Rook= k = 5 points
* Queen= v = 9 points
* King= s = 100 points
* Empty= xx

  Note: White color b, Black color s and for example Black Rook = ks , White Queen = vs

## About *Example Chess Board...*
xx xx xx ks xx xx xx ss<br />
xx ps kb xx xx xx fs xx<br />
ps xx xx xx xx xx pb ps<br />
xx xx xx fb xx xx xx xx<br />
xx xx xx as pb xx xx xx<br />
xx pb xx sb xx xx xx xx<br />
pb xx xx xx ab vs xx xx<br />
xx xx xx xx xx xx xx kb

  Note: Chess board will be readen from text document that is in Final_Exe folder.

  ![Screenshot_2](https://user-images.githubusercontent.com/32199163/124174097-9bee8280-dab4-11eb-8a91-31217e2fd846.jpg)<br />
*Black Points = (3*0.5)+(5*1)+(3*2)+(3*2)+(5*2)+9+100 = 137.5 <br />
*White Points = (1*0.5)+(7*1)+(3*2)+(3*2)+(5*2)+9+100 = 138.5
