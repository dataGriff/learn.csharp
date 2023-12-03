FROM gitpod/workspace-dotnet:latest

# Install required packages
# RUN apt-get update && apt-get install -y locales tzdata

# # Generate and set the UK locale
# RUN locale-gen en_GB.UTF-8
# ENV LANG en_GB.UTF-8
# ENV LANGUAGE en_GB:en
# ENV LC_ALL en_GB.UTF-8

# # Set the timezone to London
# ENV TZ=Europe/London
# RUN ln -fs /usr/share/zoneinfo/Europe/London /etc/localtime && dpkg-reconfigure -f noninteractive tzdata

# # Install locales and timezone data
# RUN apt-get update \
#     && apt-get install -y --no-install-recommends locales tzdata \
#     && rm -rf /var/lib/apt/lists/* \
#     && locale-gen en_GB.UTF-8

# # Set environment variables for locale and timezone
# ENV LANG en_GB.UTF-8
# ENV LANGUAGE en_GB:en
# ENV LC_ALL en_GB.UTF-8
# ENV TZ=Europe/London
