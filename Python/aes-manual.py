
import secrets

plaintext = "" # 16 bytes
ciphertext = "" # 16 bytes
key = "" # generated randomly, used per session, 16 bytes

# 4 transformations
def substitute_bytes():
    pass
def shift_rows():
    pass
def mix_columns():
    pass
def add_round_key(): # 4 bytes, 4 words (4 bytes each)
    pass

def expand_key():
    pass

def round(numberOfRounds):

    # first round
    add_round_key()
    i=0
    while (i<numberOfRounds):
        substitute_bytes()
        shift_rows()
        mix_columns()
        add_round_key()

    # last round 
    substitute_bytes()
    shift_rows()
    add_round_key()


def encryption():
    pass

def decryption():
    pass