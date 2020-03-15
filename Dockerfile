# Staging
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as stage
WORKDIR /stage
COPY . .
RUN dotnet restore
RUN apt-get update -yq \
    && apt-get install curl gnupg -yq \
    && curl -sL https://deb.nodesource.com/setup_13.x | bash \
    && apt-get install nodejs -yq
RUN dotnet publish -c Release -o output
WORKDIR /stage/output
RUN ls -l

# Runtime
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 as runtime
WORKDIR /code
COPY --from=stage /stage/output .
# Copy script from local
COPY ./wait-for-it.sh .
CMD dos2unix wait-for-it.sh
RUN chmod +x wait-for-it.sh
RUN ls -l
EXPOSE 80 5000 5001
CMD [ "./wait-for-it.sh", "sql:1433", "-t", "0", "--", "dotnet",  "DotNetCoreReactREST.dll" ]