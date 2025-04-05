# Stage 1: Build Angular App (optional)
FROM node:18-alpine AS builder

WORKDIR /app
COPY package*.json ./
RUN npm install

COPY . .
# Optional: use build step instead of ng serve
# RUN npm run build

# Stage 2: Nginx + Angular Dev Server
FROM nginx:alpine

# ✅ Install Node.js and npm (to allow running Angular CLI)
RUN apk add --no-cache nodejs npm curl supervisor

# Copy Angular source from builder
COPY --from=builder /app /app

# Install Angular CLI
RUN npm install -g @angular/cli

# Copy nginx and supervisor configs
COPY nginx.conf /etc/nginx/nginx.conf
COPY supervisord.conf /etc/supervisord.conf

WORKDIR /app

# Expose Nginx port
EXPOSE 80

# Start both Angular (ng serve) and Nginx
CMD ["/usr/bin/supervisord", "-c", "/etc/supervisord.conf"]