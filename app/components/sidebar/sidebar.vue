<template>
  <section class="sidebar-wrapper">
    <ul>
      <li v-for="option in sidebarOptions">
        <a :href="option.link">
          {{ option.label }}
        </a>
      </li>
    </ul>
  </section>
</template>

<script setup lang="ts">
interface props {
  sidebarOptions: {
    label: string;
    link: string;
  }[];
}

defineProps<props>();
</script>

<style lang="scss" src="./styles.scss"></style>
