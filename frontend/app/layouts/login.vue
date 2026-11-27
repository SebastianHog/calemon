<template>
  <div class="login-page-wrapper">
    <login-panel />
  </div>
</template>

<script lang="ts" setup></script>

<style lang="scss">
@use "~/assets/scss/tokens" as *;
@use "~/assets/scss/mixins" as *;

.login-page-wrapper {
  background: $color-primary;
  height: 100vh;
  width: 100vw;
}
</style>
