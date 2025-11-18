# Base image with VS Code setup
FROM mcr.microsoft.com/vscode/devcontainers/base:ubuntu-22.04

RUN apt-get update && apt-get upgrade -y

# Install dependencies for GHC and Haskell tools
# https://www.haskell.org/ghcup/install/#version-13
RUN apt-get install -y \
    build-essential\
    curl \
    libffi-dev \
    libffi8 \
    libgmp-dev \
    libgmp10 \
    libncurses-dev \
    libncurses6 \
    libtinfo6 \
    pkg-config

USER vscode

# Set the default shell to bash instead of sh
ENV SHELL /bin/bash

# Install ghcup
RUN curl --proto '=https' --tlsv1.2 -sSf https://get-ghcup.haskell.org | sh
ENV PATH=${PATH}:/home/vscode/.local/bin
ENV PATH=${PATH}:/home/vscode/.ghcup/bin
RUN ghcup upgrade

# Install GHC
RUN ghcup install ghc

# Install HLS
RUN ghcup install hls

# Install cabal
RUN ghcup install cabal
RUN cabal update
RUN cabal install hlint stylish-haskell

# Install stack
RUN ghcup install stack
RUN stack update
