<template>
  <div style="display: flex">
    <sidebar :sidebarOptions="sidebarOptions" />
    <slot />
  </div>
</template>

<script lang="ts" setup>
const sidebarOptions = [
  {
    label: "home",
    link: "/",
  },
  {
    label: "My calendar",
    link: "/calendar",
  },
];
</script>
