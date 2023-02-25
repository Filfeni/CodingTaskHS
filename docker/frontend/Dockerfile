FROM node:18.14.2 as node
WORKDIR /app
COPY ./BlogHS.Client/ .
RUN npm install
RUN npm run build --prod

FROM nginx:1.23.3
COPY --from=node /app/dist/blog-hs.client /usr/share/nginx/html