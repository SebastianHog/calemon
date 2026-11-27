<template>
  <NuxtRouteAnnouncer />
  <NuxtLayout :name="showLogin">
    <NuxtPage />
  </NuxtLayout>
</template>

<script lang="ts" setup>
const auth = useAuth();
const isLogged = auth.isLogged;

const showLogin = computed(() => {
  return isLogged ? "default" : "login";
});
</script>
