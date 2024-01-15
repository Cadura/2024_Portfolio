encoding = {
    "A": "C",
    "B": "D",
    "C": "E",
    "D": "F",
    "E": "G",
    "F": "H",
    "G": "I",
    "H": "J",
    "I": "K",
    "J": "L",
    "K": "M",
    "L": "N",
    "M": "O",
    "N": "P",
    "O": "Q",
    "P": "R",
    "Q": "S",
    "R": "T",
    "S": "U",
    "T": "V",
    "U": "W",
    "V": "X",
    "W": "Y",
    "X": "Z",
    "Y": "A",
    "Z": "B",
    " ": " ",
    "!": "!",
    "?": "?",
    ".": ".",
    ",": ",",
    "$": "$",
    "%": "%",
    "(": "(",
    ")": ")",
    "@": "@",
    "#": "#",
    "&": "&"
    
    }

decoding = {
    "A": "Y",
    "Z": "X",
    "Y": "W",
    "X": "V",
    "W": "U",
    "V": "T",
    "U": "S",
    "T": "R",
    "S": "Q",
    "R": "P",
    "Q": "O",
    "P": "N",
    "O": "M",
    "N": "L",
    "M": "K",
    "L": "J",
    "K": "I",
    "J": "H",
    "I": "G",
    "H": "F",
    "G": "E",
    "F": "D",
    "E": "C",
    "D": "B",
    "C": "A",
    "B": "Z",
    " ": " ",
    "!": "!",
    "?": "?",
    ".": ".",
    ",": ",",
    "$": "$",
    "%": "%",
    "(": "(",
    ")": ")",
    "@": "@",
    "#": "#",
    "&": "&"
    }

option = input("Do you want to [E]ncryptor [D]ecrypt: ")
message = input("Please enter your message: ")

if option == "E":
    for letter in message:
        newletter = encoding[letter]
        print(newletter, end="")
   
elif option == "D":
    for letter in message:
        newletter = decoding[letter]
        print(newletter, end="")
