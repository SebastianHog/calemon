<template>
  <section class="login-panel">
    <form @submit.prevent="login">
      <div>
        <h1 class="login-panel-title">Login to Calemon</h1>
        <p class="login-panel-sub-title">
          If you cannot log in, you need to ask for help from your
          administrator.
        </p>
      </div>
      <div class="login-inputs-wrapper">
        <input type="text" id="user-name" placeholder="name" />
        <input type="password" id="password" placeholder="password" />
      </div>
      <button class="login-button">Login</button>
    </form>
  </section>
</template>

<script setup lang="ts">
const login = () => {
  const login = "log";
  console.log("login");
  return login;
};
</script>

<style lang="scss" src="./styles.scss"></style>
