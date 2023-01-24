# [Choice] Node version "18", "16", "14", "18-bullseye", "16-bullseye", "14-bullseye", "18-buster", "16-buster", "14-buster"
ARG VARIANT="18"
FROM mcr.microsoft.com/devcontainers/javascript-node:0-${VARIANT}


# [Optional] Uncomment this section to install additional OS packages.
# RUN apt-get update && export DEBIAN_FRONTEND=noninteractive \
#    && apt-get -y install --no-install-recommends postgresql-client

# [Optional] Uncomment this line to install global node packages.
# RUN su vscode -c "source /usr/local/share/nvm/nvm.sh && npm install -g <your-package-here>" 2>&1