"""AES-128 for the SOEN 321 project prototype.
Educational single-block implementation.
Encrypts and decrypts one 16-byte block.
"""

from dataclasses import dataclass
import secrets

BLOCK_SIZE = 16
NUM_ROUNDS = 10 # AES-128


@dataclass
class AESKey:
    key_bytes: bytes


def generate_key() -> AESKey:
    return AESKey(secrets.token_bytes(BLOCK_SIZE))

""" 
4 transformations (encryption)
"""
def substitute_bytes(state):
    return state


def shift_rows(state):
    return state


def mix_columns(state):
    return state


def add_round_key(state, round_key):
    return state

""" 
4 transformations (decryption, inv)
"""
def inv_substitute_bytes(state):
    return state


def inv_shift_rows(state):
    return state


def inv_mix_columns(state):
    return state


def expand_key(key: bytes):
    """
    Expand 16-byte AES-128 key into round keys.
    Returns a list of 11 round keys.
    """
    return [key] * 11


def encrypt_block(plaintext: bytes, key: AESKey) -> bytes:
    if len(plaintext) != BLOCK_SIZE:
        raise ValueError("AES block must be exactly 16 bytes.")

    round_keys = expand_key(key.key_bytes)
    state = plaintext

    # Initial round
    state = add_round_key(state, round_keys[0])

    # Rounds 1 to 9
    for round_index in range(1, NUM_ROUNDS):
        state = substitute_bytes(state)
        state = shift_rows(state)
        state = mix_columns(state)
        state = add_round_key(state, round_keys[round_index])

    # Final round 
    state = substitute_bytes(state)
    state = shift_rows(state)
    state = add_round_key(state, round_keys[NUM_ROUNDS])

    return state


def decrypt_block(ciphertext: bytes, key: AESKey) -> bytes:
    if len(ciphertext) != BLOCK_SIZE:
        raise ValueError("AES block must be exactly 16 bytes.")

    round_keys = expand_key(key.key_bytes)
    state = ciphertext

    # Initial inverse round
    state = add_round_key(state, round_keys[NUM_ROUNDS])

    # Rounds 9 down to 1
    for round_index in range(NUM_ROUNDS - 1, 0, -1):
        state = inv_shift_rows(state)
        state = inv_substitute_bytes(state)
        state = add_round_key(state, round_keys[round_index])
        state = inv_mix_columns(state)

    # Final inverse round
    state = inv_shift_rows(state)
    state = inv_substitute_bytes(state)
    state = add_round_key(state, round_keys[0])

    return state